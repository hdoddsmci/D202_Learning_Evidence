## Creating Logic with TDD
* **The Cycle in Action:**
    1.  **Red:** Write a test for `Add(1, 2)` before the method exists. Fail.
    2.  **Green:** Create the `Calculator` class and `Add` method. Pass.
    3.  **Red:** Write a test for `Subtract(3, 2)`. Fail.
    4.  **Green:** Create the `Subtract` method. Pass.
* **Key Takeaway:** Only write code *after* you have a failing test that demands it.