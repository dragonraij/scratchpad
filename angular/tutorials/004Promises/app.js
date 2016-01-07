function getData($timeout, $q){
	return function(){
		var defer = $q.defer()
		
		$timeout(function() {}, 2000)
		
		return defer.promise	
	}
	
}


angular.module('app', [])
.factory('getData', getData)
.run(function(getData){
	var promise = getData()
})