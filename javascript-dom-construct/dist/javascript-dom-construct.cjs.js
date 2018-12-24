'use strict';

require('core-js/modules/web.dom.iterable');
require('core-js/modules/es6.array.iterator');
require('core-js/modules/es7.object.entries');

var a = [1, 2, 4, 5, 6, 7].map(function (number) {
  return number * 2;
});
var b = Object.entries({
  a: 5
});
console.log(a);
