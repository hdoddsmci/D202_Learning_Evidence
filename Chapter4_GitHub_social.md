## GitHub Discussions
* **Purpose:** A space for open-ended conversations, questions, and ideas that aren't necessarily "tasks" to be fixed.
* **Enabling:** Go to **Settings** > Features > **Discussions**.
* **Key Features:**
    * **Categories:** Organize talks into General, Q&A, Show and Tell, etc.
    * **Polls:** Ask the community for opinions on features.
    * **Voting:** Users can upvote useful answers (like Reddit).
    * **Convert to Issue:** If a discussion leads to a concrete task, you can click "Create issue from discussion" to move it to the tracker.
    ## Managing Notifications
* **Venues:** You can receive notifications via the **Website Inbox**, **Email**, or **Mobile App**.
* **Repo-Level Settings:** Inside a repo, click "Watch" (top right) to choose:
    * **Participating and mentions:** Only notify if someone replies to you or tags you (`@username`).
    * **All Activity:** Notify for every issue, PR, and comment.
    * **Ignore:** Mute the repo completely.
* **Global Settings:** (Profile > Settings > Notifications)
    * **Watching:** Toggle "Automatically watch repositories" to avoid getting subscribed to everything you visit.
    * **Actions:** Useful to turn on emails for "Failed Workflows" so you know if your code breaks.
* **Inbox Filters:** You can filter by "Assigned to me" or group notifications by Repository to keep things organized.
## GitHub Gists
* **Purpose:** A simple way to share code snippets or notes without creating a full repository.
* **Access:** Go to `gist.github.com` or type `gist.new` in your browser.
* **Features:**
    * **Public vs Secret:** Public gists are searchable; Secret gists are only visible to those with the link.
    * **Versioning:** Gists track history (revisions) just like a full repo.
    * **Embedding:** You can get a script tag to embed a Gist on a blog or website.
    * **Forking:** You can copy someone else's Gist to your account to modify it.
    ## GitHub Wikis
* **Purpose:** A built-in, multi-page system for hosting long-form documentation (like a user manual).
* **Technical Detail:** The Wiki is actually a separate Git repository hidden behind your main repo. You can clone it separately!
* **Features:**
    * **Multi-page navigation:** Automatically creates a sidebar for different pages.
    * **Markdown:** Supports full Markdown syntax.
    * **Custom Footer/Sidebar:** You can add `_Footer.md` or `_Sidebar.md` to content that appears on every page.
* **Visibility:** Restricted on private repos (requires Pro account), but free on public repos.