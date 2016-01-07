function getData($timeout, $q){
	return function(){
		var defer = $q.defer()
		
		//simulated async function
		$timeout(function() {
			defer.resolve('data recieved!')
		}, 2000)
		
		return defer.promise	
	}
	
}

.run(function(getData){
	var promise = getData()
	.then(function(string){
		console.log(string)
	})
})

angular.module('app', [])
.factory('getData', getData)
.run(function(getData){
	var promise = getData()
})