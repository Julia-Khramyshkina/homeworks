#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "gun.h"
#include "shell.h"

MainWindow::MainWindow(QWidget *parent) :
	QMainWindow(parent),
	ui(new Ui::MainWindow)
{
	ui->setupUi(this);
	scene = new QGraphicsScene(this);
	ui->graphicsView->setScene(scene);
	ui->graphicsView->setAlignment(Qt::AlignLeft | Qt::AlignTop);
	timer = new QTimer(this);

	ourGun = new Gun();
	scene->addItem(ourGun);
	ourTarget = new Target(ourGun->currentGun(), ourGun->counterGun());
	scene->addItem(ourTarget);
	ui->graphicsView->setScene(scene);

	QObject::connect(ui->buttonUp, &QPushButton::clicked, this, &MainWindow::down);
	QObject::connect(ui->buttonDown, &QPushButton::clicked, this, &MainWindow::up);
	QObject::connect(ui->slowly, &QRadioButton::clicked, this, &MainWindow::slowly);
	QObject::connect(ui->medium, &QRadioButton::clicked, this, &MainWindow::medium);
	QObject::connect(ui->quickly, &QRadioButton::clicked, this, &MainWindow::quickly);
	QObject::connect(timer, SIGNAL(timeout()), this, SLOT(timerUpdate()));
	QObject::connect(ui->buttonFire, &QPushButton::clicked, this, &MainWindow::fire);
}

void MainWindow::down()
{
	ourGun->changeCounter(1);
	scene->invalidate();
}

void MainWindow::up()
{
	ourGun->changeCounter(-1);
	scene->invalidate();
}

void MainWindow::fire()
{
	if (this->shellCreate)
	{
		this->shellCreate = false;
		delete ourShell;
	}

	if (ourTarget->isCheckWin())
	{
		timer->stop();
		ourTarget->newGame();
		scene->invalidate();
		return;
	}

	if (!this->changeSpeed)
	{
		this->changeSpeed = true;
		ui->slowly->click();
		ui->slowly->clicked();
		this->slowly();
	}

	this->shellCreate = true;
	ourShell = new Shell(ourGun->currentGun(), ourGun->counterGun(), speed);
	scene->addItem(ourShell);
	timer->start(this->interval);
	scene->invalidate();
}

void MainWindow::timerUpdate()
{
	ourShell->fly();
	this->win();
	scene->invalidate();
}

void MainWindow::slowly()
{
	this->speed = 5;
	this->changeSpeed = true;
}

void MainWindow::medium()
{
	this->speed = 15;
	this->changeSpeed = true;
}

void MainWindow::quickly()
{
	this->speed = 25;
	this->changeSpeed = true;
}

void MainWindow::win()
{
	if (ourShell->posX() - ourTarget->posX() <= 30 && ourShell->posX() - ourTarget->posX() >= -30 )
	{
		if (ourShell->posY() - ourTarget->posY() <= 30 && ourShell->posY() - ourTarget->posY() >= -30 )
		{
			ourTarget->winChanges();
			scene->invalidate();
		}
	}
}

MainWindow::~MainWindow()
{
	delete ui;
}
