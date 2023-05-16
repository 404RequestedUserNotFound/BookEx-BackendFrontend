var app = angular.module('my-app', []);
app.controller('publisherSearchCtrl', function($scope, $http) {
    $scope.searchPublisher = function() {
        $http.get("https://localhost:44373/api/publisher/" + $scope.publisherId)
            .then(function(response) {
                $scope.searchResult = response.data;
                console.log(response.data)
            })
            .catch(function(error) {
                console.log(error);
            });
    };
});