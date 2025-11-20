# Working with GitHub (Remotes)

## What is GitHub?
* **Definition:** An online service ("Social Coding Website") that hosts Git repositories in the cloud.
* **Purpose:** Allows developers to collaborate, track changes, manage projects (Kanban), and deploy code.
* **Key Concepts:**
    * **Remote:** A version of your repository hosted on the internet (GitHub) connected to your local computer.
    * **Push:** Uploading your local changes to the remote repository.
    * **Fetch/Pull:** Downloading changes from the remote repository to your local machine.

## Creating a Repository
* **Shortcut:** Type `github.new` in your browser to instantly start a new repo.
* **Settings:**
    * **Name:** Unique to your account (can use letters, numbers, hyphens).
    * **Public vs Private:**
        * *Public:* Anyone can see it.
        * *Private:* Only you and invited collaborators can see it.
* **Initialization:** You can optionally start with a README, .gitignore, or License.
## Connecting and Pushing
* **Managing Remotes:**
    * **Command:** `git remote add origin <url>`
        * Connects your local repository to a specific GitHub URL.
        * `origin` is the standard nickname for your primary remote server.
    * **Command:** `git remote -v` (Verbose: Lists the URLs you are connected to).
* **Pushing Code:**
    * **Command:** `git push -u origin <branch>`
        * Uploads your branch and sets the "Upstream" link (`-u`).
        * Once set, you can just type `git push` in the future.
    * **Command:** `git push --all` (Pushes **all** local branches to GitHub at once).