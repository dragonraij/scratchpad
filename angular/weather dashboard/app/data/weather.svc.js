(function (){
    angular.module("app.data")
    .factory("weatherSvc", function($http, $q){
        return {
            find:findByLocation,
            getCurrent: getCurrentWeather,
            getForecast: getForecast
        }
        
        function findByLocation(location){
            var url = "http://api.openweathermap.org/data/2.5/find?q="+location+"&APPID=aae4a1f36a91da5662b14523e312a089";
            
            var defer = $q.defer();
            
            $http.get(url)
            .success(function(response){
                defer.resolve(response);
                console.log("New : " + response )
            })
            .error(function(err){
                defer.reject(err);
            })
            
            return defer.promise;
        }
        
        function getCurrentWeather(id){
            var defer = $q.defer();
            
            var url = "http://api.openweathermap.org/data/2.5/weather?id="+id+"&APPID=aae4a1f36a91da5662b14523e312a089";
            
            $http.get(url)
                .success(function(response){
                defer.resolve(response);
            })
                .error(function(err){
                defer.reject(err);
                })
            return defer.promise;
                        
        }
        
        function getForecast(id){
            var defer = $q.defer();
            
            var url = "http://api.openweathermap.org/data/2.5/forecast/daily?id=" +id;
            
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