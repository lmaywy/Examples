/*
https://api.qunitjs.com/category/assert/
1.assert:
1.1 ok( state [, message ] )

Description: A boolean check, equivalent to CommonJS's assert.ok() and JUnit's assertTrue(). Passes if the first argument is truthy.

    ok( state [, message ] )
        state
        Type: Expression
        Expression being tested
        message
        Type: String
        A short description of the assertion

1.2 notOk( state [, message ] )  -- seems doesn't work

Description: A boolean check, inverse of ok() and CommonJS's assert.ok(), and equivalent to JUnit's assertFalse(). Passes if the first argument is falsy.

    notOk( state [, message ] )
        state
        Type: Expression
        Expression being tested
        message
        Type: String
        A short description of the assertion

1.3 equal( actual, expected [, message ] )

Description: A non-strict comparison, roughly equivalent to JUnit's assertEquals.

    equal( actual, expected [, message ] )
        actual
        Type: Object
        Expression being tested
        expected
        Type: Object
        Known comparison value
        message
        Type: String
        A short description of the assertion

*The equal assertion uses the simple comparison operator (==) to compare the actual and expected arguments.

1.4 notEqual( actual, expected [, message ] )

Description: A non-strict comparison, checking for inequality.

    notEqual( actual, expected [, message ] )
        actual
        Type: Object
        Expression being tested
        expected
        Type: Object
        Known comparison value
        message
        Type: String
        A short description of the assertion
*The notEqual assertion uses the simple inverted comparison operator (!=) to compare the actual and expected arguments.

1.5 strictEqual( actual, expected [, message ] )

Description: A strict type and value comparison.

    strictEqual( actual, expected [, message ] )
        actual
        Type: Object
        Expression being tested
        expected
        Type: Object
        Known comparison value
        message
        Type: String
        A short description of the assertion
*The strictEqual() assertion provides the most rigid comparison of type and value with the strict equality operator (===).

1.6 notStrictEqual( actual, expected [, message ] )

Description: A strict comparison, checking for inequality.

    notStrictEqual( actual, expected [, message ] )
        actual
        Type: Object
        Expression being tested
        expected
        Type: Object
        Known comparison value
        message
        Type: String
        A short description of the assertion
*The notStrictEqual assertion uses the strict inverted comparison operator (!==) to compare the actual and expected arguments. 

1.7 push( result, actual, expected, message )

Description: Report the result of a custom assertion

    push( result, actual, expected, message )
        result
        Type: Boolean
        Result of the assertion
        actual
        Type: Object
        Expression being tested
        expected
        Type: Object
        Known comparison value
        message
        Type: String
        A short description of the assertion

eg:
QUnit.assert.mod2 = function( value, expected, message ) {
    var actual = value % 2;
    this.push( actual === expected, actual, expected, message );
};
 
QUnit.test( "mod2", function( assert ) {
    assert.expect( 2 );
 
    assert.mod2( 2, 0, "2 % 2 == 0" );
    assert.mod2( 3, 1, "3 % 2 == 1" );
});

1.8 throws( block [, expected ] [, message ] )

Description: Test if a callback throws an exception, and optionally compare the thrown error.

    throws( block [, expected ] [, message ] )
        block
        Type: Function()
        Function to execute
        expected
        Type: Object
        Error Object (instance), Error Function (constructor), a RegExp that matches (or partially matches) the String representation, or a callback Function that must return true to pass the assertion check.
        message
        Type: String
        A short description of the assertion


*/