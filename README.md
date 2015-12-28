# Intro to Contest
This repo contains a bare minimum project that you can fork to start playing with contest.

#### About the source code
Within the **src** directory you will find **contest_demo.cs**. That file contains a couple of examples on how to write tests using contest. It's not a complete list of its features by any mean, is just a starting point to allow you write some tests without configuring anything.

(\* you can find more examples and the API documentation at https://github.com/amiralles/contest)

```
class Demo {
	// Test subject.
	static Order ThousandDollarsOrder = new Order { Ammount = 1000 };

	// Fluent Assertion.
	_ when_order_ammount_exceeds_1000_should_ship_for_free = 
		ensure => That(ThousandDollarsOrder.ShippingCost).Is(0d);

	// BDD style.
	_ when_order_ammount_exceeds_1000_should_ship_for_free_ = 
		expect => ThousandDollarsOrder.ShippingCost.ToBe(0d);

	// Verify Exceptions.
	_ should_throw_when_accessing_members_on_null_pointers = 
		testcase => {
			object nil = null;
			Expect(()=>nil.ToString()).ToThrow<NullReferenceException>();
	};

	// Plain old lambdas.
	_ basic_math = assert => assert.Equal(4, 2 + 2);


	//
	// Add your tests here:
	//
}
```

#### How To Build
Go to the **src** directory and run **bash build.sh**. If everything goes well, you should get an assembly called **contest\_demo.dll** into the **bin** directory at the root of the project. Now you can start running tests.


#### How To Run Tests
Go to the **tools** directory and run **bash runtests.sh**. If you didn't change the code, all tests should pass. Now it's time to add some tests.


#### How to add test cases
This project is structured in a way that allows you to start wirting test right off the bat. You won't need to add references or clases or anything like that. Just open **contest\_demo.cs** with your favorite editor and start typing. Then build, run tests, and repeat.
(This is optional, but I recommend to write a failling test, make it pass, and continue).


#### Further steps
Once you are conftable writing tests I recommend to spend some time playing with the console. Take a look at **tools/runtest.sh** and try to modify the command to filter some test, run only failing tests, see slow tests and so on and so fort. (You can see the whole list of commands at https://github.com/amiralles/contest)

