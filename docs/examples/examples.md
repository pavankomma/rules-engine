---
layout: default
title: Examples
nav_order: 99
has_children: true
permalink: docs/examples
---

# Examples

### Sample Simpleflow Script

```csharp
# Declare and initialize variables 
let userId      = none
let currentDate = $GetCurrentDateTime ( timezone: "Eastern Standard Time" )
let emailMessage= ""

# Define Rules 
rule when  arg.Name == "" 
           or arg.Name == none then
    error "Name cannot be empty"
    
rule when not $match(input: arg.Name, pattern: "^[a-zA-z]+$") then
    error "Invalid name. Name should contain only alphabets."
    
rule when arg.Age < 18 and arg.Country == "US" then
    error "You cannot register"
end rule

# Statements outside of the rules 
message "validations-completed"

rule when context.HasErrors then
    exit
end rule

# Set current date time 
partial set arg = { 
                    RegistrationDate: currentDate, 
                    IsActive: true 
                  }

# Save user data
set userId, err = $CustomerService.RegisterUser(user: arg) # User defined function

rule when err then
    error `Registration Failed. {err.Message}`
    output err
    exit
end rule

/* Upon successful registration, send an email to user
 - Error handing feature available since 1.0.4...*/

# Compose email message
set emailMessage  = `
    Hello {arg.Name},
    We would like to confirm that your account was created successfully.

    Thank you for joining.
    Date: {arg.RegistrationDate}
`

# send an email to registered user
set _, err = $SendEmail(message: emailMessage, to: arg.email)  

output userId  # access this using result.Output["userId"]
```
### Execute

```csharp
// Register custom function
var register = 
    FunctionRegister.Default
        .Add("CustomerService.RegisterUser", (Func<User, int>)RegisterUser);
        .Add("SendEmail", (Action<string, string>)SendEmail);

// Execute Dynamic Script
FlowOutput result = SimpleflowEngine.Run(rules /*above script*/, 
                                         new User {Name = "John", Age=22, Country="US" } );

// Log messages
Logger.Info(result.Messages.ToCsv());

// Check errors
if (result.Errors.Count > 0 )
{
    // Show errors
    return;
}

// Capture registered user
var userId =  result.Output["userId"];

```

```csharp

class User { 
    public string Name {get;set;}
    public string Email {get;set;}
    public int Age {get;set;}
    public string Country {get;set;}
    public bool IsActive {get;set;}
    public DateTime RegistrationDate {get;set;} 
}

static int RegisterUser(User user)
{
    return 1;
}

static void SendEmail(string message, string to)
{
    // Send email logic here
}

```