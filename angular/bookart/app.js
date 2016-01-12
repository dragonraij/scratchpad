var kartApp=angular.module('kartApp', ["ngRoute", "ngAnimate"]);

kartApp.config(function($routeProvider){
    $routeProvider
    .when("/books", {
        templateUrl: "partials/book-list.html",
        controller: "BookListCtrl"
    })
    .when("/kart", {
        templateUrl: "partials/kart-list.html",
        controller: "KartListCtrl"
    })
    .otherwise({
        redirectTo: "/books"
    });
});

kartApp.factory("kartService", function(){
    var kart = [];
    
    return {
        getKart: function(){
            return kart;
        },
        addToKart: function(book){
            kart.push(book);
        },
        buy: function(book){
            alert("Thanks for buying : ", book.name);
        }
    }
});

kartApp.factory("bookService", function(){
    var books = [
        {
            imgUrl: "pic01.jpeg",
            name: "Book One",
            price: 19.95,
            rating: 4,
            binding: "Paperback",
            publisher: "Random House",
            releaseDate: "12/4/12",
            details: "Linda is in the midsst of turmoil as she discovers that"
        },
             
                {
            imgUrl: "pic01.jpeg",
            name: "Wind in the Willows",
            price: 20,
            rating: 3,
            binding: "Hard Cover",
            publisher: "Penguin Press",
            releaseDate: "11/3/11",
            details: "The willows are not as they seem, come discover the wierd and the "
        },        {
            imgUrl: "pic01.jpeg",
            name: "Space Jam",
            price: 15,
            rating: 5,
            binding: "Paperback",
            publisher: "Universal Media",
            releaseDate: "10/3/09",
            details: "Based on the academy award winning movie, Space Jam takes you on"
        },
                {
            imgUrl: "pic01.jpeg",
            name: "Arab Spring",
            price: 14.49,
            rating: 4,
            binding: "Paperback",
            publisher: "Mid East Publishers",
            releaseDate: "1/6/14",
            details: "An insiders view at the turmoil and changes that have been come to be known as the Arab Spring"
        }
    ];
    return {
        getBooks: function(){
            return books;
        }
    }
});

kartApp.controller("KartListCtrl", function($scope, kartService){
    $scope.kart=kartService.getKart();
    $scope.buy = function(book){
        kartService.buy(book);
    }
});

kartApp.controller("HeaderCtrl", ['$scope', function($scope){
    $scope.appDetails = {
        title: "BooKart",
        tagline: "We have 1 million books for you"
    };
}]);

kartApp.controller("BookListCtrl", function($scope, bookService, kartService){
    $scope.books = bookService.getBooks(); 
    $scope.addToKart = function(book){
    kartService.addToKart(book);
}
}               
);