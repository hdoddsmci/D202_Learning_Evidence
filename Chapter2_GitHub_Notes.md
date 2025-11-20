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
    ## GitHub Interface & Options
* **Repository Header:**
    * **Watch:** Get notifications when things happen in the repo.
    * **Fork:** Create your own copy of someone else's repo to modify.
    * **Star:** Like/Bookmark a repo (indicates popularity).
* **Code Tab:**
    * **Add File:** You can "Create new" or "Upload" (Drag & Drop works too).
    * **Green "Code" Button:** Options to Clone (HTTPS/SSH), Open in Desktop, or Download ZIP.
    * **Codespaces:** A full VS Code editor running in the cloud/browser.
    * **Folder Creation Trick:** To create a folder on the website, type `foldername/` when naming a file. (Note: GitHub does not track empty folders).
* **Other Key Tabs:**
    * **Issues:** Track bugs and discuss potential changes.
    * **Pull Requests (PRs):** Request to merge changes from one branch to another.
    * **Actions:** Automation scripts (CI/CD) triggered by events like pushing code.
    * **Projects:** Kanban boards for organizing tasks.
    * **Wiki:** Simple documentation pages.
    * **Insights:** Graphs and analytics about repo activity.
* **Settings:**
    * Manage **Collaborators** (give access to others).
    * **GitHub Pages:** Host a website directly from your repo.
    * **Danger Zone:** Where you delete the repository or change visibility (Public/Private).