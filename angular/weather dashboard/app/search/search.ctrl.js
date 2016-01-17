(function(){
    angular.module("app.search")
    .controller("Search", function($scope, weatherSvc){
        $scope.cities = [];
        $scope.$on("search", search);
        
        function search(evt, data){
            
            console.log("In search module");
            weatherSvc.find(data.str)
            .then(
            function(response){
                $scope.cities=response.list;
            },
            function(err){
                console.log("error finding cities", err);
            }
            )

        }
        
    });
})();