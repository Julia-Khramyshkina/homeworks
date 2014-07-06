#include "shell.h"

Shell::Shell(qreal x, qreal y, qreal speed)
{
	this->shift = x;
	this->turn = y;
	g.setY(g.y() + 1);
	coordinate.setX(coordinate.x() + 80);
	coordinate.setY(coordinate.y());

	QTransform transform;
	transform.translate(-150, 240);
	transform.rotate(this->shift * this->turn - 3);

	this->coordinate = transform.map(this->coordinate);
	this->speedVector.setX(this->speedVector.x() + speed);
	this->speedVector.setY(this->speedVector.y());

	QTransform transform1;
	transform1.rotate(this->shift * this->turn - 3);
	this->speedVector = transform1.map(this->speedVector);
}

QRectF Shell::boundingRect() const
{
	return QRectF(10, 30, 50, 20);
}

void Shell::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
	painter->drawEllipse(this->coordinate.x(), this->coordinate.y(), 15, 15);
}


void Shell::fly()
{
	this->speedVector += this->g;
	this->coordinate.setX(this->coordinate.x() + this->speedVector.x());
	this->coordinate.setY(this->coordinate.y() + this->speedVector.y());
}

qreal Shell::posX()
{
	return this->coordinate.x();
}

qreal Shell::posY()
{
	return this->coordinate.y();
}
