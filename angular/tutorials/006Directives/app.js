angular.module('greetings', [])
.directive("welcome", function(){
	return {
		restrict:"E",
		template: "<div>Howdy there! You look splendid.</div>"
	}
})

.controller('FunCtrl', FunCtrl)

.directive("welcome2", function(){
	return {
		restrict: "A",
		link: function(){
			alert("Howdy!");
		}
	}	
})

.directive("goodbye", function(){
	return {
		restrict: "C",
		link: function(){
			alert("See ya later!");
		}
	}
})

.directive("entering", function(){
	return function(scope, element, attrs){
		element.bind("mouseenter", function(){
			scope.fun.start();
		})
	}
})

.directive("leaving", function(){
	return function(scope, element){
		element.bind("mouseleave", function(){
element.removeClass("activeClass");
		})
	}
});

function FunCtrl(){
	var self = this;
	self.start = function(){
		console.log("Fun times have been started!");
	}
}