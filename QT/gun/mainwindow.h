#pragma once

#include <QMainWindow>
#include <QGraphicsScene>
#include <QGraphicsView>
#include <QtCore>
#include <QtGui>
#include <QWidget>
#include "target.h"

namespace Ui {
class MainWindow;
}

/// Class for gun.
class Gun;

/// Class for shell.
class Shell;

class MainWindow : public QMainWindow
{
	Q_OBJECT

public:
	explicit MainWindow(QWidget *parent = 0);

	/// Processing and verification of cases to win.
	void win();
	~MainWindow();

public slots:

	/// Movement down the barrel.
	void down();

	/// Movement up the barrel.
	void up();

	/// Shot.
	void fire();

	/// Timer update.
	void timerUpdate();

	/// Rate selection. Slowly.
	void slowly();

	/// Rate selection. Medium.
	void medium();

	/// Rate selection. Quickly.
	void quickly();

private:
	Ui::MainWindow *mUi; // Has ownership.
	QGraphicsScene *mScene; // Doesn't have ownership.
	Gun *mOurGun; // Doesn't have ownership.
	Target *mOurTarget; // Doesn't have ownership.
	Shell *mOurShell; // Doesn't have ownership.
	QTimer *mTimer; // Doesn't have ownership.
	bool mChangeSpeed = false;
	qreal mSpeed;
	qreal const mInterval = 100;
	bool mShellCreate = false;
};
