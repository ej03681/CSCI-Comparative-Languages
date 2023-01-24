class Rectangle2D {

public:
	double h;
	double w;

	Rectangle2D() {
	}

	Rectangle2D(double& newH, double& newW) {
		h = newH;
		w = newW;
	}

	double getArea() {
		return w * h;
	}
	double getPerimeter() {
		return 2 * w + 2 * h;
	}
	double getWidth() {
		return w;
	}
	double getHeight() {
		return h;
	}
	void set(double& newH, double& newW) {
		h = newH;
		w = newW;
	}
};
