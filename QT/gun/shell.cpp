#include "shell.h"

Shell::Shell(qreal x, qreal y, qreal speed)
{
	this->mShift = x;
	this->mTurn = y;
	mG.setY(mG.y() + 1);
	mCoordinate.setX(mCoordinate.x() + 80);
	mCoordinate.setY(mCoordinate.y());

	QTransform transform;
	transform.translate(-150, 240);
	transform.rotate(this->mShift * this->mTurn - 3);

	this->mCoordinate = transform.map(this->mCoordinate);
	this->mSpeedVector.setX(this->mSpeedVector.x() + speed);
	this->mSpeedVector.setY(this->mSpeedVector.y());

	QTransform transform1;
	transform1.rotate(this->mShift * this->mTurn - 3);
	this->mSpeedVector = transform1.map(this->mSpeedVector);
}

QRectF Shell::boundingRect() const
{
	return QRectF(10, 30, 50, 20);
}

void Shell::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
	painter->drawEllipse(this->mCoordinate.x(), this->mCoordinate.y(), 15, 15);
}

void Shell::fly()
{
	this->mSpeedVector += this->mG;
	this->mCoordinate.setX(this->mCoordinate.x() + this->mSpeedVector.x());
	this->mCoordinate.setY(this->mCoordinate.y() + this->mSpeedVector.y());
}

qreal Shell::posX()
{
	return this->mCoordinate.x();
}

qreal Shell::posY()
{
	return this->mCoordinate.y();
}
