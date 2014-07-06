#pragma once

#include "mainwindow.h"
#include <QGraphicsScene>
#include <QGraphicsView>
#include <QGraphicsItem>
#include <QWidget>

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
	void changeCounter(qreal value);

	/// Get value corner of rotation.
	qreal currentGun();

	/// Get value count of rotations.
	qreal counterGun();

private:
	qreal currentAngleGuns = - 3;
	qreal counter = 0;
};


