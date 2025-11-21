# C# Unit Testing with xUnit

## Introduction to Unit Testing
* **Definition:** Verifies the functionality of individual units of source code. It is the first line of defense against bugs.
* **Benefits:**
    * Improves code quality.
    * Makes refactoring safer (you know if you break something).
    * Serves as "living" documentation.
    * Speeds up development by catching bugs early.
* **Impact:** Lack of testing can lead to costly software failures in the real world.

## What is xUnit?
* A free, open-source, community-focused unit testing tool for .NET.
* **Key Features:**
    * **Data-driven tests:** Run the same test with different inputs.
    * **Parallel testing:** Runs tests faster by doing them at the same time.
    * **Modern:** Designed specifically for .NET Core and modern C# development.
    ## The TDD Cycle (Test-Driven Development)
* **Methodology:** Writing tests *before* writing the corresponding code.
* **Key Terminology:**
    * **Unit Test:** Verifies a small, granular unit of functionality.
    * **Assertions:** Statements that check if the code's logic produces the expected result.
    * **Test Case:** A single scenario to test (e.g., "Adding 2 + 2 should equal 4").
    * **Test Suite:** A collection of related test cases.
* **The "Red-Green-Refactor" Process:**
    1.**Red:** Write a new test and watch it **fail** (because the feature doesn't exist yet).
    2.**Green:** Write just enough code to make the test **pass**.
    3.**Refactor:** Clean up and improve the code while ensuring the test still passes.
* ## Installing xUnit
* **Method:** xUnit is installed via the .NET CLI or Visual Studio templates.
* **Command:** `dotnet new xunit` creates a pre-configured test project.
* **Project Reference:** The test project must reference the main app project (`dotnet add reference ...`) so it can see the code it needs to test.