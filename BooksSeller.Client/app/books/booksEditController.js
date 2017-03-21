(function () {
    "use strict";

    function booksEditController($scope, booksService) {
        var vm = this;
        vm.book = {};
        vm.originalBook = {};
        vm.title = '';
        vm.message = '';

        vm.submit = submit;
        vm.backToList = backToList;
        vm.cancel = cancel;

        getBook($scope.vmMain.idBook);

        function getBook(idBook) {
            if ($scope.vmMain.idBook) {
                booksService.get({ id: $scope.vmMain.idBook }, function (book) {
                    vm.originalBook = vm.book = book;
                    vm.title = "Edit: " + vm.book.Title;
                });
            } else {
                vm.title = "New Book";
                vm.originalBook = {
                    Code: '',
                    Title: '',
                    ReleaseDate: '',
                    Price: ''
                }
            }
        }

        

        function submit(bookForm) {
            vm.message = '';
            if ($scope.vmMain.idBook) {
                booksService.update({ id: $scope.vmMain.idBook }, vm.book, function () {
                    $scope.vmMain.editionMode = false;
                });
            } else {
                booksService.create(vm.book, function () {
                    $scope.vmMain.editionMode = false;
                });
            }
        };

       function cancel(editForm) {
            editForm.$setPristine();
            vm.book = angular.copy(vm.originalBook);
            vm.message = '';
        };

        function backToList() {
            $scope.vmMain.editionMode = false;
        }

    }

    angular
    .module("booksSeller")
    .controller("booksEditController",
                 booksEditController);
}());
