using ChainOfResponsibility;

var handler = new FirstHandler();
handler.SetNext(new SecondHandler())
    .SetNext(new FirstHandler());

handler.Handle(new User() { Id = 1, Name = "a" });