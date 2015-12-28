# Intro to Contest
This repo contains a bare minimum project that you can fork to start playing with contest.

#### How To Build
Go to the **src** directory and run **bash build.sh**. If everything goes well, you should get an assembly called **contest\_demo.dll** into the **bin** directory. Now you can start running tests.


#### How To Run Tests
Go to the **tools** directory and run **bash runtests.sh**. If you didn't change the code, all tests should pass. Now it's time to add some tests.


#### How to add test cases
This project is structured in a way that allows you to start wirting test right off the bat. You won't need to add references, add clases or anything like that. Just open **contest\_demo.cs** with your favority editor and start typing. Then build, run tests, and repeat.
(This is optional, but I recommend to write a failling test, make it pass, and continue).


#### Further steps
Once you are conftable writing tests I recommend to spend some time playing with the console. Take a look at **tools/runtest.sh** and try to modify the command to filter some test, run only failing tests, see slow tests and so on and so fort. (You can see the whole list of commands at https://github.com/amiralles/contest)
