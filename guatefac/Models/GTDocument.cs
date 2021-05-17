
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace guatefac.Models
{
	[XmlRoot(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class DatosGenerales
	{
		[XmlAttribute(AttributeName = "CodigoMoneda")]
		public string CodigoMoneda { get; set; }
		[XmlAttribute(AttributeName = "FechaHoraEmision")]
		public string FechaHoraEmision { get; set; }
		[XmlAttribute(AttributeName = "NumeroAcceso")]
		public string NumeroAcceso { get; set; }
		[XmlAttribute(AttributeName = "Tipo")]
		public string Tipo { get; set; }
	}

	[XmlRoot(ElementName = "DireccionEmisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class DireccionEmisor
	{
		[XmlElement(ElementName = "Direccion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Direccion { get; set; }
		[XmlElement(ElementName = "CodigoPostal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string CodigoPostal { get; set; }
		[XmlElement(ElementName = "Municipio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Municipio { get; set; }
		[XmlElement(ElementName = "Departamento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Departamento { get; set; }
		[XmlElement(ElementName = "Pais", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Pais { get; set; }
	}

	[XmlRoot(ElementName = "Emisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Emisor
	{
		[XmlElement(ElementName = "DireccionEmisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public DireccionEmisor DireccionEmisor { get; set; }
		[XmlAttribute(AttributeName = "AfiliacionIVA")]
		public string AfiliacionIVA { get; set; }
		[XmlAttribute(AttributeName = "CodigoEstablecimiento")]
		public string CodigoEstablecimiento { get; set; }
		[XmlAttribute(AttributeName = "CorreoEmisor")]
		public string CorreoEmisor { get; set; }
		[XmlAttribute(AttributeName = "NITEmisor")]
		public string NITEmisor { get; set; }
		[XmlAttribute(AttributeName = "NombreComercial")]
		public string NombreComercial { get; set; }
		[XmlAttribute(AttributeName = "NombreEmisor")]
		public string NombreEmisor { get; set; }
	}

	[XmlRoot(ElementName = "DireccionReceptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class DireccionReceptor
	{
		[XmlElement(ElementName = "Direccion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Direccion { get; set; }
		[XmlElement(ElementName = "CodigoPostal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string CodigoPostal { get; set; }
		[XmlElement(ElementName = "Municipio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Municipio { get; set; }
		[XmlElement(ElementName = "Departamento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Departamento { get; set; }
		[XmlElement(ElementName = "Pais", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Pais { get; set; }
	}

	[XmlRoot(ElementName = "Receptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Receptor
	{
		[XmlElement(ElementName = "DireccionReceptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public DireccionReceptor DireccionReceptor { get; set; }
		[XmlAttribute(AttributeName = "CorreoReceptor")]
		public string CorreoReceptor { get; set; }
		[XmlAttribute(AttributeName = "IDReceptor")]
		public string IDReceptor { get; set; }
		[XmlAttribute(AttributeName = "NombreReceptor")]
		public string NombreReceptor { get; set; }
	}

	[XmlRoot(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Frase
	{
		[XmlAttribute(AttributeName = "CodigoEscenario")]
		public string CodigoEscenario { get; set; }
		[XmlAttribute(AttributeName = "TipoFrase")]
		public string TipoFrase { get; set; }
	}

	[XmlRoot(ElementName = "Frases", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Frases
	{
		[XmlElement(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Frase Frase { get; set; }
	}

	[XmlRoot(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Impuesto
	{
		[XmlElement(ElementName = "NombreCorto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string NombreCorto { get; set; }
		[XmlElement(ElementName = "CodigoUnidadGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string CodigoUnidadGravable { get; set; }
		[XmlElement(ElementName = "MontoGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string MontoGravable { get; set; }
		[XmlElement(ElementName = "MontoImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string MontoImpuesto { get; set; }
	}

	[XmlRoot(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Impuestos
	{
		[XmlElement(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Impuesto Impuesto { get; set; }
	}

	[XmlRoot(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Item
	{
		[XmlElement(ElementName = "Cantidad", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Cantidad { get; set; }
		[XmlElement(ElementName = "UnidadMedida", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string UnidadMedida { get; set; }
		[XmlElement(ElementName = "Descripcion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Descripcion { get; set; }
		[XmlElement(ElementName = "PrecioUnitario", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string PrecioUnitario { get; set; }
		[XmlElement(ElementName = "Precio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Precio { get; set; }
		[XmlElement(ElementName = "Descuento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Descuento { get; set; }
		[XmlElement(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Impuestos Impuestos { get; set; }
		[XmlElement(ElementName = "Total", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string Total { get; set; }
		[XmlAttribute(AttributeName = "BienOServicio")]
		public string BienOServicio { get; set; }
		[XmlAttribute(AttributeName = "NumeroLinea")]
		public string NumeroLinea { get; set; }
	}

	[XmlRoot(ElementName = "Items", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Items
	{
		[XmlElement(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Item Item { get; set; }
	}

	[XmlRoot(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class TotalImpuesto
	{
		[XmlAttribute(AttributeName = "NombreCorto")]
		public string NombreCorto { get; set; }
		[XmlAttribute(AttributeName = "TotalMontoImpuesto")]
		public string TotalMontoImpuesto { get; set; }
	}

	[XmlRoot(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class TotalImpuestos
	{
		[XmlElement(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public TotalImpuesto TotalImpuesto { get; set; }
	}

	[XmlRoot(ElementName = "Totales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Totales
	{
		[XmlElement(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public TotalImpuestos TotalImpuestos { get; set; }
		[XmlElement(ElementName = "GranTotal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string GranTotal { get; set; }
	}

	[XmlRoot(ElementName = "DatosEmision", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class DatosEmision
	{
		[XmlElement(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public DatosGenerales DatosGenerales { get; set; }
		[XmlElement(ElementName = "Emisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Emisor Emisor { get; set; }
		[XmlElement(ElementName = "Receptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Receptor Receptor { get; set; }
		[XmlElement(ElementName = "Frases", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Frases Frases { get; set; }
		[XmlElement(ElementName = "Items", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Items Items { get; set; }
		[XmlElement(ElementName = "Totales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Totales Totales { get; set; }
		[XmlAttribute(AttributeName = "ID")]
		public string ID { get; set; }
	}

	[XmlRoot(ElementName = "NumeroAutorizacion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class NumeroAutorizacion
	{
		[XmlAttribute(AttributeName = "Numero")]
		public string Numero { get; set; }
		[XmlAttribute(AttributeName = "Serie")]
		public string Serie { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Certificacion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class Certificacion
	{
		[XmlElement(ElementName = "NITCertificador", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string NITCertificador { get; set; }
		[XmlElement(ElementName = "NombreCertificador", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string NombreCertificador { get; set; }
		[XmlElement(ElementName = "NumeroAutorizacion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public NumeroAutorizacion NumeroAutorizacion { get; set; }
		[XmlElement(ElementName = "FechaHoraCertificacion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public string FechaHoraCertificacion { get; set; }
	}

	[XmlRoot(ElementName = "DTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class DTE
	{
		[XmlElement(ElementName = "DatosEmision", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public DatosEmision DatosEmision { get; set; }
		[XmlElement(ElementName = "Certificacion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public Certificacion Certificacion { get; set; }
		[XmlAttribute(AttributeName = "ID")]
		public string ID { get; set; }
	}

	[XmlRoot(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class SAT
	{
		[XmlElement(ElementName = "DTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public DTE DTE { get; set; }
		[XmlAttribute(AttributeName = "ClaseDocumento")]
		public string ClaseDocumento { get; set; }
	}

	[XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class CanonicalizationMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignatureMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transform
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transforms
	{
		[XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Transform Transform { get; set; }
	}

	[XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class DigestMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Reference
	{
		[XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Transforms Transforms { get; set; }
		[XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public DigestMethod DigestMethod { get; set; }
		[XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string DigestValue { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "URI")]
		public string URI { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignedInfo
	{
		[XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public CanonicalizationMethod CanonicalizationMethod { get; set; }
		[XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureMethod SignatureMethod { get; set; }
		[XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Reference> Reference { get; set; }
	}

	[XmlRoot(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignatureValue
	{
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class X509Data
	{
		[XmlElement(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string X509Certificate { get; set; }
	}

	[XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class KeyInfo
	{
		[XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public X509Data X509Data { get; set; }
	}

	[XmlRoot(ElementName = "CertDigest", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class CertDigest
	{
		[XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public DigestMethod DigestMethod { get; set; }
		[XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string DigestValue { get; set; }
	}

	[XmlRoot(ElementName = "IssuerSerial", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class IssuerSerial
	{
		[XmlElement(ElementName = "X509IssuerName", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string X509IssuerName { get; set; }
		[XmlElement(ElementName = "X509SerialNumber", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string X509SerialNumber { get; set; }
	}

	[XmlRoot(ElementName = "Cert", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class Cert
	{
		[XmlElement(ElementName = "CertDigest", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public CertDigest CertDigest { get; set; }
		[XmlElement(ElementName = "IssuerSerial", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public IssuerSerial IssuerSerial { get; set; }
	}

	[XmlRoot(ElementName = "SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class SigningCertificate
	{
		[XmlElement(ElementName = "Cert", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public Cert Cert { get; set; }
	}

	[XmlRoot(ElementName = "SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class SignedSignatureProperties
	{
		[XmlElement(ElementName = "SigningTime", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public string SigningTime { get; set; }
		[XmlElement(ElementName = "SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public SigningCertificate SigningCertificate { get; set; }
	}

	[XmlRoot(ElementName = "SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class SignedProperties
	{
		[XmlElement(ElementName = "SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public SignedSignatureProperties SignedSignatureProperties { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
	public class QualifyingProperties
	{
		[XmlElement(ElementName = "SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public SignedProperties SignedProperties { get; set; }
		[XmlAttribute(AttributeName = "xades", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xades { get; set; }
		[XmlAttribute(AttributeName = "xades141", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xades141 { get; set; }
		[XmlAttribute(AttributeName = "Target")]
		public string Target { get; set; }
	}

	[XmlRoot(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Object
	{
		[XmlElement(ElementName = "QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
		public QualifyingProperties QualifyingProperties { get; set; }
	}

	[XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Signature
	{
		[XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignedInfo SignedInfo { get; set; }
		[XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureValue SignatureValue { get; set; }
		[XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public KeyInfo KeyInfo { get; set; }
		[XmlElement(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Object Object { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "GTDocumento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
	public class GTDocumento
	{
		[XmlElement(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
		public SAT SAT { get; set; }
		[XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Signature> Signature { get; set; }
		[XmlAttribute(AttributeName = "dte", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Dte { get; set; }
		[XmlAttribute(AttributeName = "ds", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ds { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "Version")]
		public string Version { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
	}

}
