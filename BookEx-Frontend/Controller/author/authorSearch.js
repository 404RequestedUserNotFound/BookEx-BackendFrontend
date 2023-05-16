var app = angular.module('my-app', []);
app.controller('authorSearchCtrl', function($scope, $http) {
    $scope.searchAuthor = function() {
        $http.get("https://localhost:44373/api/author/" + $scope.authorId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});