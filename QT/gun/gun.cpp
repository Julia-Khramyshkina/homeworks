#include "gun.h"

#include "mainwindow.h"

#include <QTransform>

Gun::Gun(){}

QRectF Gun::boundingRect() const
{
	return QRectF(-200, 250, 120, 50);
}

void Gun::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{

	painter->drawEllipse(-200, 200, 90, 90);
	painter->translate(-150, 240);
	painter->rotate(this->currentAngleGuns * this->counter);
	painter->drawRect(0, 0, 80, 10);
}

void Gun::changeCounter(qreal value)
{
	if (value == 1)
		++this->counter;
	if (value == -1)
		--this->counter;
}

qreal Gun:: currentGun()
{
	return this->currentAngleGuns;
}

qreal Gun:: counterGun()
{
	return this->counter;
}
