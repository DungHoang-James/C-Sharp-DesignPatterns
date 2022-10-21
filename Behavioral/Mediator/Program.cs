
var mediator = new ConcreteMediator();

var c1 = new Colleague1();
var c2 = new Colleague2();

mediator.Register(c1);
mediator.Register(c2);

c1.Send("c1");
c2.Send("c2");