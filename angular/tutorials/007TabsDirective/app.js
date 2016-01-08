;(function(window){
	angular.module('app', [])
	//define directives
	.directive('tab', function(){
		return {
			restrict: 'E',
			transclude: true,
			template: '<h2>Hello World!</h2> <div role="tabpanel" ng-transclude></div>',
			scope: {},
			link: function(sscope, elem, attr){}
		}
	})
})(window);