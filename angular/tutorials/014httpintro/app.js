var app = angular.module("app", [])
.service('testService', testService)
.controller('TestCtrl', TestCtrl)


function testService($http){
	this.get = function(){
		return $http.get('http://test-routes.herokuapp.com/test/hello')
		.then(function(res){
			//return the enveloped data
			return res.data.message;
		})
	}
}

function TestCtrl(testService){
	var self = this;
	
	self.getMessage = function(){
		testService.get()
		.then(function(res){
			self.message = res.data.message;
		})
	}
	
}