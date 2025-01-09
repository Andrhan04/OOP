using team;
using team.Enabling;
using team.Movement;
using team.Movement.WheelsParams;
using team.Movement.WheelsParams.BugsyToolsCompany;
using team.Movement.WheelsParams.RosentialElectronics;
using team.Senses.EchoSounderParams;

// Создаем инструменты

RemoteController r_controller = new RemoteController();

WheelsBugsyB wheels_B = new WheelsBugsyB();
WheelsRosentialR wheels_R = new WheelsRosentialR();
EchoSounder echo = new EchoSounder();
Enable e = new Enable();

// Делаем команды

WheelsActivateB w_a = new WheelsActivateB(wheels_B);
WheelsDeactivateB w_da = new WheelsDeactivateB(wheels_B);
WheelsForwardB w_f = new WheelsForwardB(wheels_B);
WheelsBackB w_b = new WheelsBackB(wheels_B);
WheelsToLeftB w_l = new WheelsToLeftB(wheels_B);
WheelsToRightB w_r = new WheelsToRightB(wheels_B);
WheelsStopB w_s = new WheelsStopB(wheels_B);

WheelsActivateR w_a1 = new WheelsActivateR(wheels_R);
WheelsDeactivateR w_da1 = new WheelsDeactivateR(wheels_R);
WheelsForwardR w_f1 = new WheelsForwardR(wheels_R);
WheelsBackR w_b1 = new WheelsBackR(wheels_R);
WheelsToLeftR w_l1 = new WheelsToLeftR(wheels_R);
WheelsToRightR w_r1 = new WheelsToRightR(wheels_R);
WheelsStopR w_s1 = new WheelsStopR(wheels_R);

EchoActivate e_a = new EchoActivate(echo);
EchoDeactivate e_da = new EchoDeactivate(echo);
EchoCheck e_c = new EchoCheck(echo);

TurnOn t_on = new TurnOn(e);
TurnOff t_off = new TurnOff(e);

MovementOnEcho m = new MovementOnEcho(echo, w_f, w_b);

// Макросы

ICommand[] activate = { t_on, w_a, e_a };
ICommand[] deactivate = { t_off, w_da, e_da };
ICommand[] move = { e_c, m };

MacroCommands activateMacro = new MacroCommands(activate);
MacroCommands deactivateMacro = new MacroCommands(deactivate);
MacroCommands moveMacro = new MacroCommands(move);


// Забиваем команды на кнопки

r_controller.setCommand(0, w_f);
r_controller.setCommand(1, w_f1);
r_controller.setCommand(2, w_l);
r_controller.setCommand(3, w_b);
r_controller.setCommand(4, w_s);
r_controller.setCommand(5, e_c);
r_controller.setCommand(6, activateMacro);
r_controller.setCommand(7, moveMacro);

// Проверка

Console.WriteLine(r_controller.showCommand());

r_controller.onButtonWasPushed(0);

Console.WriteLine('\n');

r_controller.onButtonWasPushed(1);

Console.WriteLine('\n');

r_controller.onButtonWasPushed(5);

Console.WriteLine('\n');

r_controller.onButtonWasPushed(6);
r_controller.offButtonWasPushed(6);

Console.WriteLine('\n');

r_controller.onButtonWasPushed(7);

Console.WriteLine('\n');