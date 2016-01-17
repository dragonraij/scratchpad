(function(){
    angular.module("app.forecast")
    .controller("Forecast", function($scope, $routeParams, weatherSvc){
        $scope.forecast = null;
        $scope.getTime = getTime;
        console.log("In forecast module");   
        if ($routeParams.id !==undefined){
            
            getForecast($routeParams.id);
        }
        
        function getForecast(id){
            
            weatherSvc.getForecast(id)
                .then(
                function(response){
                    $scope.forecast = response;
                    console.log($scope.forecast);
                }, 
            function(err){
                console.log("could not get forecast", err);   
            })
        }
        
        function getTime(dt) {
                return new Date(dt * 1000);
            }
    });
})();