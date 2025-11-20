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