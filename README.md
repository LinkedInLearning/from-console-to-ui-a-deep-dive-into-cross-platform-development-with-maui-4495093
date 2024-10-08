# From Console to UI: A Deep Dive into Cross-Platform Development with MAUI

This is the repository for the LinkedIn Learning course "From Console to UI: A Deep Dive into Cross-Platform Development with MAUI." 

![tn-url]

<p>Explore the steps involved in building cross-platform applications using the .NET MAUI framework. First, review the key features and benefits of MAUI and steps for setting up a new project. Then, find out how to create a service layer to manage data and business logic, ensuring a clean separation from the UI, and how to configure the database path for SQLite databases. Learn how to leverage the Model-View-ViewModel (MVVM) pattern, creating views for listing and editing notes, including adding necessary validations to improve data integrity. </p>
<br/>
<p>The course also covers reading, updating, and deleting notes through the UI, and using CRUD operations within a MAUI app. Become adept at setting up MAUI projects, implementing MVVM, handling data operations, and working with MAUI controls for a comprehensive application development experience. Join instructor Jesse Freeman who helps you gain the confidence and skills needed to build and deploy powerful cross-platform applications with .NET.</p>

## Instructions

This repository has branches for each of the lessons in the course. You can use the branch pop-up menu in GitHub to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go directly to the branch you want to access.

## Branches

The branches are structured to correspond to the lessons in the course. The naming convention is `lesson-CHAPTER.MOVIE`. For example, the branch named `lesson-1.2` corresponds to Chapter 1, Lesson 2.

### Example Branch List

- `lesson-0.0`
- `lesson-1.2`
- `lesson-1.3`
- `lesson-1.4`
- `lesson-2.1`

The `main` branch holds the final state of the code as presented at the end of the course.

### Switching Branches

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

```
error: Your local changes to the following files would be overwritten by checkout:        [files]
Please commit your changes or stash them before you switch branches.
Aborting
```

To resolve this issue:

- Add changes to git using this command: `git add .`
- Commit changes using this command: `git commit -m "some message"`

## Running the Project

To run this project using Visual Studio, follow these steps:

1. **Clone the Repository:**
   - Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.

2. **Open the Project:**
   - Open Visual Studio.
   - Select `File` > `Open` > `Project/Solution`.
   - Navigate to the cloned repository folder and select the solution file (.sln).

3. **Restore Dependencies:**
   - Visual Studio will prompt you to restore the dependencies for the project. Click `Restore` to ensure all NuGet packages are installed.

4. **Select the Startup Project:**
   - In the Solution Explorer, right-click on the desired startup project (e.g., `HelloNote.UI`) and select `Set as Startup Project`.

5. **Build and Run the Project:**
   - Click on the `Start` button (or press `F5`) to build and run the project.
   - Select the target platform (e.g., Android, iOS, Windows) and ensure your device/emulator is set up correctly.

## Installing

To use these exercise files, you must have the following installed:

- Visual Studio 2022 or later
- .NET 7
- .NET MAUI workload

Follow the instructions on the [Microsoft .NET MAUI documentation](https://docs.microsoft.com/dotnet/maui/get-started/installation) to set up your development environment.

[tn-url]: https://media.licdn.com/dms/image/D560DAQEQWe7sELWFfg/learning-public-crop_675_1200/0/1722571094854?e=2147483647&v=beta&t=pW4jjN4N19tlqQ1_M8Gb_MAdf6kzKr9EkplBfPJdfSE
