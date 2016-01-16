(function (){
    angular.module("app.data")
    .factory("weatherSvc", function($http, $q){
        return {
            find:findByLocation
        }
        
        function findByLocation(location){
            var url = "http://api.openweathermap.org/data/2.5/weather?q="+location+"&APPID=aae4a1f36a91da5662b14523e312a089";
            
            var defer = $q.defer();
            
            $http.get(url)
            .success(function(response){
                defer.resolve(response);
            })
            .error(function(err){
                defer.reject(err);
            })
            
            return defer.promise;
        }
    });
})();