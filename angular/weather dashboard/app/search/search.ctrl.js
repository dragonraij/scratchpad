(function(){
    angular.module("app.search")
    .controller("Search", function($scope, weatherSvc){
        $scope.$on("search", search);
        
        function search(evt, data){
            weatherSvc.find(data.str)
            .then(
            function(response){
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