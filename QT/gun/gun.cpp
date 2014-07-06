#include "gun.h"

#include <QTransform>

#include "mainwindow.h"


Gun::Gun(){}

QRectF Gun::boundingRect() const
{
	return QRectF(-200, 250, 120, 50);
}

void Gun::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
	painter->drawEllipse(-200, 200, 90, 90);
	painter->translate(-150, 240);
	painter->rotate(this->mCurrentAngleGuns * this->mCounter);
	painter->drawRect(0, 0, 80, 10);
}

void Gun::changeCounter(qreal value)
{
	if (value == 1)
		++this->mCounter;

	if (value == -1)
		--this->mCounter;
}

qreal Gun::currentGun()
{
	return this->mCurrentAngleGuns;
}

qreal Gun::counterGun()
{
	return this->mCounter;
}
