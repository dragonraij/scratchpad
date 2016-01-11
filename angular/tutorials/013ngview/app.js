var app = angular.module("app", []);

app.config(function($routeProvider){
	$routeProvider.when("/",
	{
		templateUrl: "app.html",
		controller: "AppCtrl",
		controllerAs: "app"
	}
	);
});

app.controller('AppCtrl', function(){
	var self = this;
	self.message = "The app routing is working!";
})