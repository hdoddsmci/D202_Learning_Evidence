# Chapter 1: Version Control Overview

## What is Git?
* **Version Control System:** Git acts like a "historian with a time machine" for code.
* **History Tracking:** It tracks changes to files over time, allowing you to jump back and forth between versions.
* **Commits:** These are "save points" or checkpoints with messages describing what happened.
* **Branching:** Allows creating alternate realities/versions of the project to work on features without affecting the main original.
* **Merging:** The process of synchronizing branches back together.

## Tools Required
* **Git:** The core tool (download from git-scm.com).
* **Terminal:** Required to run commands (Git Bash on Windows, Terminal on Mac).
* **Node.js:** Often required for handling web project tools.
* **VS Code:** Recommended text editor.

## Setting up Git
* **Configuration:** Before starting, configure your identity so changes are credited to you.
    * Command: `git config --global user.name "Your Name"`
    * Command: `git config --global user.email "you@example.com"`
* **Initializing:** `git init` transforms a current folder into a Git repository.
    * This creates a hidden `.git` folder where Git stores all tracking data.
* **Staging:** The "waiting area" for files before they are committed.
    * Command: `git add .` (adds all files in the directory to staging).
* **Committing:** Saves the snapshot of the staged files to history.
    * Command: `git commit -m "Message"`
* **Checking History:** `git log` shows a list of all past commits.
