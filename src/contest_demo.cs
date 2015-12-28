#pragma warning disable 414 //<= otherwise we will get a warning for every test.

using System;
using Contest.Core;
using static Contest.Core.Chatty;
using static Contest.Core.BDD;
using _ = System.Action<Contest.Core.Runner>;


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
}


// Basic entity
class Order {
    public double Ammount = 0, Tax = 0; 
	public double ShippingCost { 
		get { return Ammount >= 1000d ? 0d : 50d; }
	}
}
