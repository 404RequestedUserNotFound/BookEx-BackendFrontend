var app = angular.module('my-app', []);
app.controller('borrowUpdateCtrl', function($scope, $http) 
{
  $scope.updateBorrow = function() 
  {
    var data = {
        Id: $scope.borrowId,
        userId: $scope.userId,
        BookId: $scope.bookId,
        BorrowDate: $scope.borrowDate,
        DueDate: $scope.dueDate,
        ReturnDate: $scope.returnDate,
        Status: $scope.status,
        Fine: $scope.fine
      };
    $http.post("https://localhost:44373/api/borrow/update", data).then(function(resp) 
    {
      location.reload();

      alert("Borrow Information has been updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
