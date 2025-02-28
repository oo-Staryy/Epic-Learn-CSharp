using Task_1.Services;

UserUpdateService service = new();

TimeMeter.Run(service.UpdateUsers);