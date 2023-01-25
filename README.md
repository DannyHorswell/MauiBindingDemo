# MauiBindingDemo
#App to demonstrate Maui binding issue

## Description of project

This project is a minimisation of a project I have been working on that was not working right.

For the project I was workign on, I have a singleton app model object set up in DI that stores state information for the app.
The app model holds a list of objects, that contains another list of objects.

On the app I have 2 Content pages in an app shell.

The first shows top level list is displayed vertically in a scroll view. The 2nd level list is displayed vertically in columns of 2.
The 2nd content page I have inputs and buttons that allow the user to post data to a server, and on response, this may change the content of the lists in the model.

What I found was that the UI on the first content page was not updating in a timely fashion and often not updating at all.

For this sample project, I have recreated removing as much of the original app to see if I could reproduce the issue.
This project does not have DI but stores the global stat object as a static object (MauiProgram.AppModleSingleton)

There are 2 content pages, TestContentPage1 contains a view similar to the original app, but I have aded buttons that allow adding and removing items from each list in the model. On the original app, this is just a view page that allows each object to be selected.

The 2nd page is a duplicate of TestContentPage2, that also allows modification of the model.


## Workign nicely

If you run the app and just use the firat page, all workes nicely.

https://danny-smilecomputersolutions.tinytake.com/msc/NzgxODU4MV8yMDg3NzQzNg

# Going wrong

Binding fails whene interacing to model from another content page

https://danny-smilecomputersolutions.tinytake.com/msc/NzgxODYzMV8yMDg3NzUxNg


# Versions

This project was created on a fresh machine with Maui project created from Visual Studio 17.4.4, Version shown below.

Videos above shown on Android Emulator_31. My origonal project were showing issues on Android phisical devices A22, J5 and J6


### dotnet --list-sdks
7.0.102 [C:\Program Files\dotnet\sdk]

### dotnet workload list

Installed Workload Id      Manifest Version       Installation Source
---------------------------------------------------------------------
maui-windows               7.0.52/7.0.100         VS 17.4.33213.308
maui-maccatalyst           7.0.52/7.0.100         VS 17.4.33213.308
maccatalyst                16.1.1477/7.0.100      VS 17.4.33213.308
maui-ios                   7.0.52/7.0.100         VS 17.4.33213.308
ios                        16.1.1477/7.0.100      VS 17.4.33213.308
maui-android               7.0.52/7.0.100         VS 17.4.33213.308
android                    33.0.4/7.0.100         VS 17.4.33213.308



