#pragma once

#include "mainwindow.h"
#include <QGraphicsScene>
#include <QGraphicsView>
#include <QGraphicsItem>

/// This is gun class.
class Gun : public QGraphicsItem
{
public:
	Gun();

	/// Rectangle for paint gun.
	QRectF boundingRect() const;

	/// Paint gun.
	void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

	/// Change state of trunk.
	/// @value change corner.
	void changeCounter(qreal value);

	/// Get value corner of rotation.
	qreal currentGun();

	/// Get value count of rotations.
	qreal counterGun();

private:
	qreal const mCurrentAngleGuns = - 3;
	qreal mCounter = 0;
};


