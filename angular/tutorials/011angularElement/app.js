var app = angular.module("app", [])

app.directive("dumbPassword", function () {
    var validElement = angular.element('<div>{{model.input}}</div>');
  return {
      restrict: "E",
      replace: true,
      templateUrl: "dumbpass.html",
      compile: function (tElem){
          tElem.append(validElement);

          return function(scope){
              scope.$watch("model.input", function (value){
                  if (value === "password") {
                      validElement.toggleClass("alert-box alert");
                  }
              });
          }
      }
      
  }
});