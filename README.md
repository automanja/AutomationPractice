# AutomationPractice
AutomationPractice is repository that contains functional UI tests for application http://automationpractice.com. Solution is developed using Page Object Model framework, Page Factory method and Selenium Web Driver. 

## Table of Contents
- [Project description](#project-description)
- [Getting started](#getting-started)
- [Prerequisites](#prerequisites)
- [Importing the project](#importing-the-project)
- [Running the tests](#running-the-tests)
- [Notes](#notes)

## Project description
This project is used to test sign in, search and to verify particular element existance. In those test scenario we create user profile, verify certain elements on the page, search for a product and verify results. Search results are then written to text file named Results.tx in project root folder *\AutomationPractice.

Solution contains two projects: AutomationPracticeLibrary and AutomationPracticeTests. 

### AutomationPracticeLibrary
AutomationPracticeLibrary  is class library project that holds all Project and Selenium configuration, Page and Repository classes. All classes are grouped within folders.
**Pages folder** contains classes that represent page object classes. Each application page has it's belonging class. Page class is used to hold all actions that we perform on that particular page. 
**Repository folder** contains classes that are used only as repositories for web element. Each Page class has its Repository class that holds web elements for that single page.
**Selenium folder** contains Driver and PageUtils class. Driver class is responsible for all actions that are related to Web Driver, like create driver, close driver. PageUtils class contains customized selenium commands like enter, click, select, wait...  
**Manage folder** contains class that is used to manipulate writting to txt file  
### AutomationPracticeTests
AutomationPracticeTests is test project that holds unit test clasess. This project has folder **TestConfig** and it contains BaseTest class which is used as base for each automated test. It contains TestInitialize part with all setting that should be perforemd before test is executed (set driver, open browser, open url,...) and TestCleanup that is performed when test is finished (close browser).


## Getting started
Following instructions will help you to set project up and run on your local machine for testing purposes.
### Prerequisites
To use this project and run tests you need to have installed:
- Visual Studio Professional 2019 or
- Visual Studio Express 2019
- Chrome browser
- Notepad

## Importing the project
Selenium Project needs to be imported in Visual Studio 2019. To do so, please follow next steps:
1. Download project from Github
2. Open Visual Studio 2019
2. Select File from menu
3. Select Open -> Project/Solution
4. Browse for project AutomationPractice that you previously downloaded from Github
5. Click on button Open

## Running the tests
To run the test in Visual Studio, following steps should be executed:
1. Select Test from main menu in Visual Studio
2. Select Test Explorer
3. In Solution Explorer right click on solution and select Build
4. In Test Explorer right click on test you want to run and select Run 
5. View results in Test Explorer

## Notes
Tests are granulated by tasks required in code challange. In real situation this would be organized differently as last test doesn't actually assert anything.

PageFactory is deprecated in c#. At the moment this library is not maintained so it will be removed from Visual Studio until further notice. Removing PageFactory limits certain POM functionalities so at the moment PageFactory is used within the project to keep with Page Object Model and to have easyily maintained code.
