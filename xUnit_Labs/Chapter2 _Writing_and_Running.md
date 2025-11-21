## Writing Tests & Assertions
* **[Fact] Attribute:** Decorator that tells xUnit "This method is a test."
    * Syntax: `[Fact] public void MethodName() { ... }`
* **Naming Conventions:** Test names should be descriptive so you can identify failures easily in a long list.
* **Assert.True(condition):** Checks if a boolean condition is true.
    * Example: `Assert.True(5 > 3);` // Passes
    * Example: `Assert.True(1 == 2);` // Fails
    *## Common Assertions
* **Assert.Equal(expected, actual):** Checks if two values are identical.
    * Example: `Assert.Equal(4, 2 + 2);`
* **Assert.NotEqual(expected, actual):** Checks if two values are DIFFERENT. Passing if they do NOT match.
    * Example: `Assert.NotEqual(5, 2 + 2);` // Passes because 4 is not 5.
* **Assert.True(condition):** Verified in previous video.
* ## Core Workflow & Parameterized Tests
* **AAA Pattern (Arrange, Act, Assert):**
    * **Arrange:** Set up variables and initialize objects.
    * **Act:** Execute the method you are testing.
    * **Assert:** Verify the result matches your expectation.
* **Parameterized Tests:**
    * **[Theory]:** Replaces `[Fact]`. Tells xUnit "This test expects input data."
    * **[InlineData]:** Supplies the data for the test parameters.
    * *Benefit:* You can test edge cases (like negative numbers or zeros) without writing brand new methods.
    * ## Expanded Assertions Toolkit
* **Booleans:**
    * `Assert.False(condition)`: Verifies a condition is false.
* **Nulls:**
    * `Assert.Null(object)`: Verifies an object is null.
    * `Assert.NotNull(object)`: Verifies an object exists (is not null).
* **Collections:**
    * `Assert.Contains(item, collection)`: Checks if a list contains a specific item.
    * `Assert.Empty(collection)`: Checks if a list has 0 items.
    * `Assert.NotEmpty(collection)`: Checks if a list has items.
* **Ranges:**
    * `Assert.InRange(value, min, max)`: Checks if a number falls within a range.