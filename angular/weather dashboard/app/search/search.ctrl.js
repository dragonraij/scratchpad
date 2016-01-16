(function(){
    angular.module("app.search")
    .controller("Search", function($scope, weatherSvc){
        $scope.cities = [];
        $scope.$on("search", search);
        
        function search(evt, data){
            weatherSvc.find(data.str)
            .then(
            function(response){
                $scope.cities=response.list;
                //$scope.cities.push(response) ;
                console.log(response);
            },
            function(err){
                console.log("error finding cities", err);
            }
            )
            //for debug
            console.log(data.str);
        }
        
    });
})();