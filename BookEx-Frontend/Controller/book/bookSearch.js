var app = angular.module('my-app', []);
app.controller('bookSearchCtrl', function($scope, $http) {
    $scope.searchBook = function() {
        $http.get("https://localhost:44373/api/book/" + $scope.bookId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});
