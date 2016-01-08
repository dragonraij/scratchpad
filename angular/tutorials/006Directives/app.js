angular.module('greetings', [])
.directive("welcome", function(){
	return {
		restrict:"E",
		template: "<div>Howdy there! You look splendid.</div>"
	}
})

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
	return function(scope, element){
		element.bind("mouseenter", function(){
			console.log("Mouse has entered the div");
		})
	}
})

.directive("leaving", function(){
	return function(scope, element){
		element.bind("mouseleave", function(){
			console.log("Mouse has left the div");
		})
	}
});