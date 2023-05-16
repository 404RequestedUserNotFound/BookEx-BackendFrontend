var app = angular.module('my-app', []);
app.controller('categorySearchCtrl', function($scope, $http) {
    $scope.searchCategory = function() {
        $http.get("https://localhost:44373/api/category/" + $scope.categoryId)
            .then(function(response) {
                $scope.searchResult = response.data;
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});
