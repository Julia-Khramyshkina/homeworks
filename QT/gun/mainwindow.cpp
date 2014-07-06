#include "mainwindow.h"
#include "ui_mainwindow.h"

#include "gun.h"
#include "shell.h"
MainWindow::MainWindow(QWidget *parent) :
	QMainWindow(parent),
	mUi(new Ui::MainWindow)
{

	mUi->setupUi(this);
	mScene = new QGraphicsScene(this);
	mUi->graphicsView->setScene(mScene);
	mUi->graphicsView->setAlignment(Qt::AlignLeft | Qt::AlignTop);
	mTimer = new QTimer(this);

	mOurGun = new Gun();
	mScene->addItem(mOurGun);
	mOurTarget = new Target(mOurGun->currentGun(), mOurGun->counterGun());
	mScene->addItem(mOurTarget);
	mUi->graphicsView->setScene(mScene);

	QObject::connect(mUi->buttonUp, &QPushButton::clicked, this, &MainWindow::down);
	QObject::connect(mUi->buttonDown, &QPushButton::clicked, this, &MainWindow::up);
	QObject::connect(mUi->slowly, &QRadioButton::clicked, this, &MainWindow::slowly);
	QObject::connect(mUi->medium, &QRadioButton::clicked, this, &MainWindow::medium);
	QObject::connect(mUi->quickly, &QRadioButton::clicked, this, &MainWindow::quickly);
	QObject::connect(mTimer, SIGNAL(timeout()), this, SLOT(timerUpdate()));
	QObject::connect(mUi->buttonFire, &QPushButton::clicked, this, &MainWindow::fire);
}

void MainWindow::down()
{
	mOurGun->changeCounter(1);
	mScene->invalidate();
}

void MainWindow::up()
{
	mOurGun->changeCounter(-1);
	mScene->invalidate();
}

void MainWindow::fire()
{
	if (this->mShellCreate)
	{
		this->mShellCreate = false;
		delete mOurShell;
	}

	if (mOurTarget->isCheckWin())
	{
		mTimer->stop();
		mOurTarget->newGame();
		mScene->invalidate();
		return;
	}

	if (!this->mChangeSpeed)
	{
		this->mChangeSpeed = true;
		mUi->slowly->click();
		mUi->slowly->clicked();
		this->slowly();
	}

	this->mShellCreate = true;
	mOurShell = new Shell(mOurGun->currentGun(), mOurGun->counterGun(), mSpeed);
	mScene->addItem(mOurShell);
	mTimer->start(this->mInterval);
	mScene->invalidate();
}

void MainWindow::timerUpdate()
{
	mOurShell->fly();
	this->win();
	mScene->invalidate();
}

void MainWindow::slowly()
{
	this->mSpeed = 5;
	this->mChangeSpeed = true;
}

void MainWindow::medium()
{
	this->mSpeed = 15;
	this->mChangeSpeed = true;
}

void MainWindow::quickly()
{
	this->mSpeed = 25;
	this->mChangeSpeed = true;
}

void MainWindow::win()
{
	if (mOurShell->posX() - mOurTarget->posX() <= 30 && mOurShell->posX() - mOurTarget->posX() >= -30 )
	{
		if (mOurShell->posY() - mOurTarget->posY() <= 30 && mOurShell->posY() - mOurTarget->posY() >= -30 )
		{
			mOurTarget->winChanges();
			mScene->invalidate();
		}
	}
}

MainWindow::~MainWindow()
{
	delete mTimer;
	delete mScene;
	delete mUi;
}
