# Eau Claire's Salon

#### By _**Alex Shevlin**_ 

#### _A web app that allows a Salon to manage employees and clients._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Technology Requirements](#technology-requirements)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Known Bugs](#known-bugs)**

---

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _REPL_
* _EntityFrameWork_
* _MySQL WorkBench_

## Description

_This is an MVC application to help a Salon keep track of stylists and each stylist's clients. The salon owner can see a list of stylists, select a stylist and see their details with a list of all clients for that stylist. The salon owner can add new stylists to the system when they are hired, and new clients to a specific stylist._

---
## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Clone this project and place files in a folder named `HairSalon.Solution`
    <pre>HairSalon.Solution
    └── HairSalon</pre>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsettings.json file in the "HairSalon" directory of the project*  
   <pre>HairSalon.Solution
   └── HairSalon
    └── appsettings.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=alex_shevlin;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, navigate back to SQL Workbench.
<li>Import the database named "alex_shevlin.sql" from the root directory of the project.<br><br>
How to Import a Database:
<ol> 
<li>Open SQL Workbench.
  <li>Navigate to "Administration" tab in SQL Workbench.
  <li>Click "Data Import/Restore".
  <li>Select the radio button "Import from Self-Contained File" and include file path to the sql file of this project you cloned to your machine.
  <li>In "Default Schema to be Imported to" click "New".
  <li>Name the schema "alex_shevlin" then click "OK".
  <li>Once named, switch to "Import Progress" tab and click "Start Import".
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>HairSalon.Solution
   └── <strong>HairSalon</strong>

Run ```$ dotnet run``` in the console
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _No known bugs_

## License

[GNU](/LICENSE-GNU)

Copyright (c) 2022 Alex Shevlin