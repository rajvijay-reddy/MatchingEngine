Selenium webdriver in C# with Page Object Model design pattern
This framework is implemented for web-based automation projects and developed using selenium, C# using Page Object Model.
Currently only supports test execution in Chrome or Edge browser.

Pre-requisites
Windows OS
Visual Studio

Get Started
Clone the Project

Installation
Visual Studio
Start Visual Studio
Click on File>>Open>> Project / Solution.
Navigate to the project folder and select "MatchingEngine.sln".

The tests by default executes in Chrome browser. If required to execute tests on Edge change the 'browser' key to value 'Edge'.


How to execute the TestCase

Tests can be executed via Visual Studio Code or via terminal

To execute through terminal

Under the menu click on Build -> Build Solution.
On successful completion of the build, under the menu click Test -> Run All Tests.

To Execute code through Terminal
Open the terminal, navigate to the project folder and execute command 'dotnet build .\MatchingEngine.sln'.
On successful completion of the build, run test by executing command 'dotnet test .\MatchingEngine.sln'.

Contact
If you have any questions or need some help with the repo, please do contact me. Thanks.