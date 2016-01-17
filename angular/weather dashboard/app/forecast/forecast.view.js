(function(){
    angular.module("app.forecast")
    .directive("customForecast", function(){
        return {
            restrict: "AE",
            replace: true,
            scope: {
                dp: "="
            },
            template: "<div id='container'></div>",
            link: linkFn
        }
        
        function linkFn(scope, element, attrs){
            console.log(element);
        }
    });
}());