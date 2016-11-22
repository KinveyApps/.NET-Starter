# .NET-Starter
A Kinvey starter application built on the .NET v3.0 SDK

_Note: This starter app uses the [Kinvey .NET v3 Library](http://devcenter.kinvey.com/dotnet-v3.0)._

## Features

* Login a user.
* Find a list of books from Kinvey backend.

## Setup

1. Create an app backend using the [console](http://console.kinvey.com) for your application.
2. Create a user (with password) using the [console](http://console.kinvey.com) for your application.
3. Clone the repo.
4. Open `DotNET-Starter.sln` in Visual Studio.
5. Assign the App ID and App Secret from the created backend to the `app_key` and `app_secret` variables in `MainWindow.xaml.cs`.
6. Assign the username and password of the created user to the `username` and `password` variables in `MainWindow.xaml.cs`.
7. Build entire solution.

## Run

By default, the type of data store created for the `books` collection is `DataStoreType.NETWORK`.

## License

Copyright (c) 2016 Kinvey Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
in compliance with the License. You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in
writing, software distributed under the License
is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
or implied. See the License for the specific language governing permissions and limitations under
the License.
