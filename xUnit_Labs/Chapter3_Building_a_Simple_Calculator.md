## Creating Logic with TDD (Add & Subtract)
* **Goal:** Build a Calculator using the Red-Green-Refactor cycle.
* **Workflow:**
    1.  **Create Test Class:** Start with a clean test file (e.g., `CalcTests`).
    2.  **The "Red" Phase (Add):**
        * Write `AddTwoIntegers` test using Arrange-Act-Assert.
        * Fails because the `Add` method doesn't exist yet.
    3.  **The "Green" Phase (Add):**
        * Create the `Calculator` class and the `Add(int a, int b)` method.
        * Run test -> Passes.
    4.  **The "Red" Phase (Subtract):**
        * Write `SubtractTwoIntegers` test.
        * Fails because the `Subtract` method doesn't exist.
    5.  **The "Green" Phase (Subtract):**
        * Implement `Subtract(int a, int b)`.
        * Run test -> Passes.
* **Namespace Tip:** Ensure your Test project is using the namespace of your App project (`using HelloCalcApp;`) so it can see the classes.
* ## Refactoring with TDD
* **Refactoring:** The process of restructuring existing computer code without changing its external behavior.
* **Safety Net:** Unit tests ensure that your changes (refactoring) didn't break the existing logic (Regression Testing).
* **C# Features Used:**
    * **`params` keyword:** Allows a method to accept a variable number of arguments (e.g., `Add(1, 2, 3, 4)`).
    * **LINQ:** Used `.Sum()` and `.Aggregate()` to simplify the math logic into single lines.
    * ## Testing State & History
* **State:** Data stored inside an object (like a List of previous results).
* **Challenge:** We must ensure the state is correct after every operation.
* **Test Strategy:**
    1.  Perform multiple actions (e.g., Add twice).
    2.  Check the `Count` of the history list.
    3.  Verify specific items at specific indexes (e.g., `History[0]`
 ## Parsing Equation Strings
* **Goal:** Process a string (e.g., `"10 + 5 - 2"`) and return the calculated integer.
* **Logic:**
    1.  **Clean:** Remove whitespace.
    2.  **Split:** Separate numbers from operators (`+`, `-`).
    3.  **Iterate:** Loop through the operators, applying the math sequentially to a running total.
* **Dictionary Pattern:** Using a `Dictionary<char, Func<int, int, int>>` is a clean way to map symbols (`+`) to code actions (`(a,b) => a+b`).