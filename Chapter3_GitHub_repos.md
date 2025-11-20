## GitHub Issues
* **Purpose:** Track bugs, feature requests, and general discussions.
* **Key Features:**
    * **Assignees:** Who is responsible for this task?
    * **Labels:** Tags to categorize issues (e.g., `bug`, `enhancement`, `help wanted`).
    * **Milestones:** Groups issues into a larger goal with a deadline (e.g., "v1.0 Launch").
    * **Mentions:** Use `@username` to notify specific people.
* **Markdown:** Issues support full Markdown (tables, checklists, alerts).
* **Closing:** When a task is done, you "Close" the issue (it moves to the "Closed" filter).
## Pull Requests (PRs)
* **Definition:** A request to merge changes from a feature branch into the main branch. It acts as a "discussion forum" for code before it is finalized.
* **The Workflow:**
    1.  **Branch:** Create a new branch for your changes (never work on `main`).
    2.  **Propose:** Open a Pull Request on GitHub comparing your branch to `main`.
    3.  **Review:** Teammates review the code, leave comments, and request changes.
    4.  **Merge:** Once approved, the PR is merged into `main`.
* **Key Features:**
    * **Reviewers:** People assigned to check the code.
    * **Files Changed:** A "Diff" view showing exactly what lines were modified.
    * **Linking Issues:** You can link a PR to an issue (e.g., "Closes #4"). When the PR merges, the Issue closes automatically.
 
    * ## Advanced Pull Request Features
* **Draft Pull Requests:**
    * A placeholder for work-in-progress code.
    * Allows discussion but **cannot be merged** until marked "Ready for Review".
    * Useful for getting early feedback before the code is finished.
* **The Review Interface:**
    * **Files Changed Tab:** Shows the specific code differences ("Diffs").
    * **Line Comments:** You can click the `+` sign on any line of code to leave a specific comment or suggestion.
    * **Review Actions:**
        * **Comment:** General feedback without blocking.
        * **Approve:** The code is good to merge.
        * **Request Changes:** Blocks the merge until the specific issues are fixed.
## Finishing a Code Review
* **Resolving Conversations:**
    * When you fix an issue raised by a reviewer, click **Resolve conversation** to hide the comment thread.
    * This signals that the feedback has been addressed.
* **Pushing Fixes:**
    * Simply make the changes on your local branch, commit, and push.
    * The Pull Request updates **automatically** with the new commits.
* **Merging:**
    * Once all conversations are resolved and checks pass, click **Merge pull request**.
    * **Confirm merge** to finalize the changes into the main branch.
## Branch Protection & Code Owners
* **CODEOWNERS File:**
    * Assigns specific users to specific files or folders.
    * **Effect:** When a Pull Request touches those files, these users are *automatically* added as reviewers.
    * **Syntax:** `* @username` (Assigns everything to one person).
* **Branch Protection Rules:**
    * Located in **Settings > Branches**.
    * **"Require pull request before merging":** No one can push directly to `main`.
    * **"Require approval":** The code *cannot* be merged until a Code Owner reviews and clicks "Approve".
    * **Result:** This enforces a high quality standard and prevents accidental bugs in production.
