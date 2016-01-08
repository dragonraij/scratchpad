angular.module('greetings', [])
.directive("welcome", function(){
	return {
		restrict:"E",
		controller: function($scope){
			$scope.words = [];
			
			this.sayHello = function(){
				$sscope.words.push("Helllo");
			};
			
			this.sayHowdy = function(){
				$scope.words.push("howdy");
			};
			
			this.sayHi = function(){
				$scope.words.push("hi")	
			};
		},
		
		link: function(scope, element){
			element.bind("mouseenter", function(){
				console.log(scope.words);
			});
		}
	}
})

//used to interact with the main controller welcome
.directive("hello", function(){
	return {
		require: "welcome",
		link: function (scope, element, attrs, welcomeCtrl){
			welcomeCtrl.sayHello();
		}
	};
})


.directive("howdy", function(){
	return {
		require: "welcome",
		link: function (scope, element, attrs, welcomeCtrl){
			welcomeCtrl.sayHowdy();
		}
	};
})

.directive("hi", function (){
	return{
		require: 'welcome',
		link: function(scope, element, attrs, welcomeCtrl){
			welcomeCtrl.sayHi();
		}
	};
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
			scope.$apply(attrs.entering);
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
	
	self.end = function(){
		console.log("Fun times is over");
	}
}