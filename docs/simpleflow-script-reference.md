---
layout: default
title: Simpleflow Script Reference
nav_order: 2
---

# Simpleflow Script Reference
{: .fs-9 }

1. [Script Outline](#script-outline)
1. [Variables](#variables)
1. [Data Types](#data-types)
1. [Operators](#operators)
1. [Expressions](#expressions)
1. [Script Parameters](#script-parameters)
1. [Rule Control Flow](#rule-control-flow)
1. [Emitters](#emitters)
1. [Functions](#functions)
1. [Comment](#comment)


### Script Outline

```
<let statements>* 
(<rule statements> or <emitters> or <functions> or <set>)* 
```


### Variables <a name="variables"></a>
```fsharp
let <variablename> = expression
```
> <small> Expressions can be used with only variable. Anywhere else you need expression then declare variable,  assign expression and use it.</small>

**Modify value of a variable** <br>
```csharp
[partial] set <variablename> = expression
```

### Data Types

<table>
    <tr>
        <th> Data Type </th>
        <th> Description/Examples</th>
    </tr>
    <tr>
        <td>Number</td>
        <td>
                <code>let x = 1 </code><br>
                <code>let y = 2.3 </code><br>
                <code>let z = -442.33 </code><br>
            </div>
        </td>
    </tr>
    <tr>
        <td>String</td>
        <td>
            let name = "test"
        </td>
    </tr>
    <tr>
        <td>Boolean</td>
        <td>
            <code>let hasValue = true </code><br>
            <code>let allow = false </code><br>
        </td>
    </tr>
    <tr>
        <td>Date</td>
        <td>
            Use date function to declare a variable as date type. <br>
            <code>let birthday = $date(y:1980, m: 1, d: 1 )</code>
        </td>
    </tr>
    <tr>
        <td>Object Type</td>
        <td>
            Object type can be defined using JSON format. It does not support nested object syntax, but in order to set
            nested object, you can set to a variable and use it. <br><br>
            <code>let address = {city: 'ny'} </code><br>
            <code>let member = {name: 'alex', address: address }</code>
        </td>
    </tr>
</table>



### Operators

| Operator Type | Operators             |
|---------------|-----------------------|
| Arithmetic    | +,-,*,/               |
| Logical       | and, or, not          |
| Relational    | <, <=, >, >=, == , != |

### Expressions
```csharp
let v = 2 + 3 * (3 * arg.value); 
```

### Script Parameters
`arg` and `context`
`arg` represents the input to the script.

**Context Properties:** context.HasErrors,  context.HasMessages context.HasOutput

### Rule Control Flow
```csharp
rule when <predicate> then
	<statement..1>	
	<statement..2>
	<statement..N>
[end rule]
```

> <small> condition does not allow expression. If you need to write expression
declare variable and write expression and use that variable in predicate. This does not support nested rules to avoid code complexity</small>

### Emitters

| Emitter Type | Syntax                      |
|--------------|-----------------------------|
| message      | message <string/identifier> |
| error        | error <string/identifier>   |
| output       | output 	<identifier>         |
| exit         | exit                        |

### Functions
```csharp
$<function_name>(param_name1: value1, param_name2: value2, ...)
```
Function parameters can be written in any order. and if you omit a parameter it takes a default value of that type.
Function cannot be an argument to another function. Store output of a function in a variable and use it.

<table>
    <tr>
        <th> Function </th>
        <th> Syntax/Examples</th>
    </tr>
    <tr>
        <td>Date</td>
        <td>
            <div>
                $$\color{#4686f2}{\$Date(y: int, m: int, d: int, [h:int, mn: int, s: int])}$$ <br>
                <code>let d1 = $Date(y: 2022, m: 7, d:11) </code><br>
                <code>let d2 = $Date(m: 10, d:25, y: 2022 ) </code><br>
                <code>let t1 = $Date(m: 10, d:25, y: 2022, h:13, mn:30 ) </code>
            </div>
        </td>
    </tr>
    <tr>
        <td>GetCurrentDate</td>
        <td>
            $\color{#4686f2}{\$GetCurrentDate()}$
        </td>
    </tr>
    <tr>
        <td>GetCurrentTime</td>
        <td>
            $\color{#4686f2}{\$GetCurrentTime()}$
        </td>
    </tr>
    <tr>
        <td>GetCurrentDateTime</td>
        <td>
            $\color{#4686f2}{\$GetCurrentDateTime(timeZone: "")}$ <br>
	    <a href="https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11#time-zones">Windows Timezones List</a><br>
	    <a href="https://manpages.ubuntu.com/manpages/bionic/man3/DateTime::TimeZone::Catalog.3pm.html">Ubuntu Timezones List</a><br>
            <code>let today = $GetCurrentDateTime() </code> <br>
            <code>let todayEst = $GetCurrentDateTime ( timezone: "Eastern Standard Time" )</code>
        </td>
    </tr>
    <tr>
        <td>Substring</td>
        <td>
            $\color{#4686f2}{\$Substring(input: string, startIndex:int, length: int)}$
        </td>
    </tr>
    <tr>
        <td>IndexOf</td>
        <td>
            $\color{#4686f2}{\$IndexOf(input: string, value:string, startIndex: int) }$
        </td>
    </tr>
    <tr>
        <td>Length</td>
        <td>
            $\color{#4686f2}{\$Length(input: string) }$
        </td>
    </tr>
    <tr>
        <td>Contains</td>
        <td>
            $\color{#4686f2}{\$Contains(input: string, value:string) }$
        </td>
    </tr>
    <tr>
        <td>StartsWith</td>
        <td>
            $\color{#4686f2}{\$StartsWith(input: string, value:string) }$
        </td>
    </tr>
    <tr>
        <td>EndsWith</td>
        <td>
            $\color{#4686f2}{\$EndsWith(input: string, value:string) }$
        </td>
    </tr>
    <tr>
        <td>Trim</td>
        <td>
            $\color{#4686f2}{\$Trim(input: string, value:string) }$
        </td>
    </tr>
    <tr>
        <td>Match</td>
        <td>
            $\color{#4686f2}{\$Match(input: string, pattern:string) }$
        </td>
    </tr>
    <tr>
        <td>Concat</td>
        <td>
            $\color{#4686f2}{\$Concat(value1: string, value2:string, value3:string, value4:string, value5:string)}$ <br>
            <code>let value = $Concat ( value1: "I ", value2: "got it" )</code>
        </td>
    </tr>
</table>
    
### Comment
It supports only one style of comment can be used for single or multiline using /* .. */
```csharp
/* Write your comment here */
```